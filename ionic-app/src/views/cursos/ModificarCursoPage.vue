<template>
     <ion-page>
        <ion-header>
            <ion-toolbar>
                <ion-buttons slot="start">
                    <ion-back-button default-href="/tabs/cursos"></ion-back-button>
                </ion-buttons>
                <ion-title tabindex="0">Modificar nombre del curso</ion-title>
            </ion-toolbar>
        </ion-header>
        <ion-content>
            <div class="form-container">
                <form v-on="curso">
                <ion-label for="nombreCurso">Nombre del curso:</ion-label>
                <ion-input type="text" v-model="nombreCurso" :value="curso.nombre" />
                <ion-button @click="updateCurso(curso, nombreCurso)">Modificar</ion-button>
                </form>
            </div>
        </ion-content>
    </ion-page>
</template>

<script>
import {  IonPage, IonHeader, IonToolbar, IonTitle, IonContent, IonInput, IonLabel, IonButton, IonButtons, IonBackButton } from '@ionic/vue';
import axios from 'axios';
import { loading } from '../overlay-views/loading.js';
import { alertDialog } from '../overlay-views/alertDialog.js';

export default {
    components: { IonPage, IonHeader, IonToolbar, IonTitle, IonContent, IonInput, IonLabel, IonButton, IonButtons, IonBackButton },
    methods:{
        updateCurso(curso, nuevoNombre){
            loading.showMsg("Modificando curso...");
            axios.put("/api/Cursos/" + curso.id,{
                "id": curso.id,
                "nombre": nuevoNombre
                }).then(resp => {
                    loading.hide();
                    alertDialog.showAlertMsg("Curso modificado satisfactoriamente!");
                    curso.nombre = nuevoNombre;
                });
            }
    },
    computed:{
        curso(){
            return this.$store.getters.curso(this.$route.params.id);
        }
    }
}
</script>

<style scoped>
.form-container {
  text-align: center;
  position: absolute;
  left: 0;
  right: 0;
  top: 50%;
  transform: translateY(-50%);
}
</style>