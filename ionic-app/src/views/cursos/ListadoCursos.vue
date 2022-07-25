<template>
    <tabs-base page-title="Mis cursos">
        <ion-list>
          <ion-item router-link="cursos/add" >
            <ion-button class="boton-agregar-item">+ Nuevo curso </ion-button>
          </ion-item>
  
          <h1 class="empty-list-msg" v-if="cursos.length == 0"> No hay elementos para mostrar</h1>
          <ion-item button ref="listItem" v-bind:key="curso.id" v-for="curso in cursos">
            <ion-label tabindex="0" :router-link="`cursos/${curso.id}`">
              <strong>{{curso.nombre}}</strong> <br>
              <p>Cant. de estudiantes: {{curso.estudiantes}}</p>
            </ion-label>
            <!-- <ion-button button id="click-trigger" slot="end"> -->
            <ion-button button @click="openPopover($event, curso.id)" slot="end">
              <!--<ion-icon slot="icon-only" :icon="ellipsisVertical"></ion-icon> -->
              Más
            </ion-button>

            <ion-popover side="left" alignment="start"
            :is-open="popoverOpen"
            :event="event"
            @didDismiss="popoverOpen = false">
            <ion-content>
              <ion-item :id="`${curso.id}`" button @click="deleteCurso(this.popoverCursoId)">Eliminar curso</ion-item>
              <ion-item button @click="closePopover()" :router-link="`cursos/update/${this.popoverCursoId}`">Modificar nombre</ion-item>
            </ion-content>
          </ion-popover>
          </ion-item>
        </ion-list>
    </tabs-base>
</template>

<script>
import { IonList, IonItem, IonLabel, IonButton, /*IonIcon,*/ IonPopover, } from '@ionic/vue';
import TabsBase from "../../components/base/TabsBase.vue";
//import { chevronForwardOutline, ellipsisVertical } from 'ionicons/icons';
import axios from 'axios';
import { loading } from '../overlay-views/loading.js';
import { alertDialog } from '../overlay-views/alertDialog.js';

export default({
  name: 'ListadoCursos',
  components: {
    IonList,
    IonItem,
    IonLabel,
    TabsBase,
    IonButton,
    IonPopover,
    //IonIcon
  },
  data() {
    return {
      popoverOpen: false,
      event: null,
      popoverCursoId: null
    }
  },
  async mounted() {
    
    loading.showMsg('Cargando cursos...');

    axios.get("/api/Cursos/")
    .then(resp => {
        console.log(resp);
        this.$store.commit('load',resp.data);
        loading.hide();
    })
    .catch(err => {
      console.log(err);
      loading.hide();
    });
    
  },
  methods:{
    openPopover(e, id) {
        this.event = e;
        this.popoverOpen = true;
        this.popoverCursoId = id;
    },

    deleteCurso(id){
      this.popoverOpen = false;
      alertDialog.showAlertMsgWithButtons("Esta acción no se puede deshacer. ¿Seguro que quiere eliminar el curso?",
        [
          {
            text: 'Eliminar',
            role: 'delete',
            handler: () => { this.handlerMessage = this.delete(id); }
          },
          {
            text: 'Cancelar',
            role: 'cancel',
          }
        ]
      )
    },

    async delete(id){

      loading.showMsg('Eliminando curso...');

      axios.delete("/api/Cursos/" + id)
      .then(() => {
        loading.hide();  
        alertDialog.showAlertMsg("Curso eliminado!");
        this.$store.dispatch('delete', id);
      })
      .catch(err => {
            loading.hide();
            alertDialog.showAlertMsg("No se pudo eliminar el curso. Error: " + err.message);
      });
    },

    closePopover(){
      this.popoverOpen = false;
    },

  },
  computed: {
    cursos() {
      return this.$store.getters.cursos;
    }
  },
  setup(){
      return{
        //chevronForwardOutline,
        //ellipsisVertical
      }
    }
});
</script>

<style scoped>
.boton-agregar-item{
  background-color: lightseagreen;
  color: black;
}

.empty-list-msg{
  text-align: center;
  left: 0;
  right: 0;
}
</style>