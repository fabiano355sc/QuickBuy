import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  template: "Produto cadastrado >> {{ obterNome() }}"
})

export class ProdutoComponent {
    
  public nome: string;
  public liberadoVenda: boolean;

  public obterNome(): string {
    return "Samsung";
  }

}
