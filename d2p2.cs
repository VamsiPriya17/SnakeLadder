using System;
class HelloWorld {
  public static int position = 0;
  static int dice(){
      Random diceRoll = new Random();
      int roll = diceRoll.Next(1,7);
      
      return roll;
  }
  static void startGame(){
      Random diceRoll = new Random();
         int number = dice();
         int choice = diceRoll.Next(0,3);
         if(choice != 0){
             if(choice == 1){
                 position += number;
                 if(position > 100)
                     position = 100;
             }
             else{
                 position -= number;
                 if(position < 0)
                    position = 0; 
             }
         }
         switch(number){
            case 0: Console.WriteLine("No Play!");
                    break;
            case 1: Console.WriteLine("Got up the ladder to position : " + position);
                    break;
            case 2: Console.WriteLine("Got down the snake to position : " + position);
                    break;
         } 
  }
  static void startGame2(ref int position, ref int times){
      Random diceRoll = new Random();
         int number = dice();
         int choice = diceRoll.Next(0,3);
         do{
             times++;
             if(choice != 0){
                 if(choice == 1){
                     position += number;
                     if(position > 100){
                         position = 100;
                         break;
                     }
                 }
                 else{
                     position -= number;
                     if(position < 0){
                        position = 0;  
                     }
                 }
             }
             switch(number){
                case 0: Console.WriteLine("No Play!");
                        break;
                case 1: Console.WriteLine("Got up the ladder to position : " + position);
                        break;
                case 2: Console.WriteLine("Got down the snake to position : " + position);
                        break;
             } 
         }while(choice == 1);
         
  }
  static void uc_1(){
      Console.WriteLine("Single Player at Start Poisition 0.");
      int times = 0;
      while(position != 100){
        times++;
        startGame();
      }
      Console.WriteLine("Won at chance " + times + "!");
  }
  static void uc_2(){
      int times1 = 0, times2 = 0, player1 = 0, player2 = 0;
      while(player1 != 100 || player2 != 100){
          Console.WriteLine("Player 1 chance");
          startGame2(ref player1, ref times1);
          Console.WriteLine("Player 2 chance");
          startGame2(ref player2, ref times2);
      }
      if(player1 != 100){
          Console.WriteLine("Player 2 won at chance " + times2 + "!");
      }
      else{
          Console.WriteLine("Player 1 won at chance " + times1 + "!");
      }
  }
  static void Main() {
    uc_1();
    uc_2();
  }
}