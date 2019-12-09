ETEC Professor Hor�cio Augusto da Silveira
Avalia��o de Design Digital � Segundo Bimestre � Usabilidade e Padr�es de Projeto

Nome:Tabata Teixeira Grigaitis_____________________________________



class Bananador 
{
    private double banana;
    private double suquinho;
    private string guarana;
        private void calculator(){
            try {
                banana = Convert.ToDouble(txtbanana.Text);
                suquinho = Math.Sqrt(banana);
                guarana = Convert.ToString(suquinho); 
             txtResultado.Text = guarana;
            } 
            catch(FormatException){ 
                MessageBox.Show("Formatação Errada.");
            }
        }
}


1.	Organize o c�digo acima segundo o que foi explicado nas aulas de t�cnicas de programa��o afim de garantir legibilidade e sustentabilidade do c�digo.

2.	Desenhe uma classe que implemente o c�digo acima como um m�todo. 
