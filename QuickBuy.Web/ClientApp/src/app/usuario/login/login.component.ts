import { Component } from "@angular/core"
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent {

  public usuario;
  public usuarioAutenticado: boolean;

  constructor() {
    this.usuario = new Usuario();
  }

  entrar() {
    if (this.usuario.email == "fabiano355sc@gmail.com" && this.usuario.senha == "123") {
      this.usuarioAutenticado = true;
    }else {
      alert(this.usuario.email + " - " + this.usuario.senha);
    }    
  }
}
