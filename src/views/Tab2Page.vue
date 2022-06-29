<template> 
    <!-- <div role="tabpanel" id="panel-cursos" ref="panelCursos" tabindex=""> -->
    <ion-page tabindex="0">
      <ListadoCursos />
    </ion-page>
</template>

<script>
import ListadoCursos from '../components/ListadoCursos.vue';
import { IonPage } from '@ionic/vue'

export default ({
  name: 'Tab2Page',
  components: { 
    ListadoCursos,
    IonPage
  }/*,
  mounted: function(){
    this.focusear();
  },
  methods: {
    focusear(){
      this.$refs.panelCursos.focus();
    }
  }*/
});
</script>
