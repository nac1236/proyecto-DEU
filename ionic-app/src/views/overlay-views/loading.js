import { loadingController } from '@ionic/vue'

class Loading{
    constructor(){
        this.loading = null;

        Loading.instance = this;
        return this;
    }

    async create(){
        this.loading = await loadingController.create();
    }

    setMessage(msg){
        this.loading.message = msg;
    }

    show(){
        this.loading.present();
    }

    hide(){
        this.loading.dismiss();
        this.loading = null;
    }

    async showMsg(msg){
        await this.create();
        this.setMessage(msg);
        this.show();
    }

}

let loading = new Loading();
console.log("Loading initialized!");

export {loading};

// JS classes --->  https://developer.mozilla.org/es/docs/Web/JavaScript/Reference/Classes 

// Patron Singleton ---> https://medium.com/@jesusmurfontanals/singleton-pattern-con-javascript-3eb1c03f184e