<template>
    <tabs-base page-title="Mis cursos">
        <ion-list>
          <ion-item :key="curso.id" v-for="curso in cursos" :router-link="`cursos/${curso.id}`">
            <ion-label>
              <strong>{{curso.nombre}}</strong> <br>
              <p>Cant. de estudiantes: {{curso.estudiantes}}</p>
            </ion-label>
          </ion-item>

        </ion-list>
    </tabs-base>
</template>

<script>
import { IonList, IonItem, IonLabel } from '@ionic/vue';
import TabsBase from "./base/TabsBase.vue";

export default({
  name: 'ListadoCursos',
  components: {
    IonList,
    IonItem,
    IonLabel,
    TabsBase
  },
  computed: {
    cursos() {
      return this.$store.getters.cursos;
    }
  }
});
</script>