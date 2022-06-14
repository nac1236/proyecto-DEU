<template>
    <base-cursos>
        <h1>Mis cursos</h1>
        <ion-list>
          <!-- <ion-item>holaa</ion-item>
          <ion-item>chauu</ion-item> -->
          <ion-item :key="curso.id" v-for="curso in cursos">
            <ion-label>
              <strong>{{curso.nombre}}</strong> <br>
              <p>Cant. de estudiantes: {{curso.estudiantes}}</p>
            </ion-label>
          </ion-item>

        </ion-list>
    </base-cursos>
</template>

<script>
import { defineComponent } from 'vue';
import { IonList, IonItem, IonLabel } from '@ionic/vue';
import Tab2Page from '../views/Tab2Page.vue';

export default ({
  name: 'ListadoCursos',
  // props: {
  //   name: String
  // },
  components: {
    IonList,
    IonItem,
    IonLabel,
    Tab2Page
  },
  data() { 
    return {
      cursos: [ { id: 1, nombre: "historia", estudiantes: 6}, 
                { id: 2, nombre: "inundaciones", estudiantes: 10}, 
                { id: 3, nombre: "arroyo maldonado", estudiantes: 4}
              ] 
    }}
});
</script>