<template>
    <tabs-base page-title="Login">
        <form autocomplete="on">
            <ion-label for="email">Email:</ion-label>
            <ion-input type="text" name="email" id="email" v-model="email" />
            <ion-label for="contraseña">Contraseña:</ion-label>
            <ion-input type="password" name="contraseña" id="contraseña" v-model="contraseña" />
            <!--<ion-button class="login_button" type="submit">Ingresar</ion-button> -->
            <ion-button router-link="/tabs">Ingresar</ion-button>
            <a href="/signup">¿Todavía no creaste un usuario? Registrar.</a>
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