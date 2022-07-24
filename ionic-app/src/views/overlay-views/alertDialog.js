import { alertController } from '@ionic/vue'

class AlertDialog{
    constructor(){
        this.alert = null;
        this.defaultDismissButton = [{
            text: 'Aceptar',
            role: 'accept',
            handler: () => {alertDialog.dismissAlert()}
        }]

        AlertDialog.instance = this;
        return this;
    }

    async create(){
        this.alert = await alertController.create();
    }

    setMessage(msg){
        this.alert.message = msg;
    }

    setButtons(buttons){
        this.alert.buttons = buttons;
    }

    presentAlert(){
        this.alert.present();
    }

    dismissAlert(){
        this.alert.dismiss();
        this.alert = null;
    }

    async showAlertMsg(msg){
        await this.create();
        this.setMessage(msg);
        this.setButtons(this.defaultDismissButton);
        this.presentAlert();
    }

    // To specify custom buttons. Don´t forget to add one button with handler: () => {alertDialog.dismissAlert()} 
    async showAlertMsgWithButtons(msg,buttons){
        await this.create();
        this.setMessage(msg);
        this.setButtons(buttons);
        this.presentAlert();
    }

}

let alertDialog = new AlertDialog();
console.log("Alert initialized!");

export {alertDialog};
