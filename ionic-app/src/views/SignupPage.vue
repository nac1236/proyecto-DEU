<template>
    <tabs-base pageTitle="Registrarse">
        <form>
            <ion-label for="email">Email:</ion-label>
            <ion-input type="text" name="email" id="email" v-model="email" />
            <ion-label for="nombre de usuario">Nombre de usuario:</ion-label>
            <ion-input type="text" name="nombre de usuario" id="nombre de usuario" v-model="username" />
            <ion-label for="password">Contraseña:</ion-label>
            <ion-input type="password" name="password" id="password" v-model="password" />
            <ion-button router-link="/login">Terminar registro</ion-button>
        </form>
    </tabs-base>
</template>

<script>
import TabsBase from '../components/base/TabsBase.vue'
import { IonInput, IonLabel, IonButton } from '@ionic/vue'

export default {
    components: {
        TabsBase,
        IonInput,
        IonLabel,
        IonButton
    }
}
</script>