using System.Threading;
namespace Dotnet.POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack (){
           return this.Name + " Lançou Magia";
        }
        public string Attack (int Bonus){

            if (Bonus > 6){
                return this.Name + " Lançou Magia Super Efetiva com bônus de " + Bonus;
            } else{
                return this.Name + " Lançou umna magia com força fraca com bônus de  " + Bonus;
            }
            
        }

    }
}