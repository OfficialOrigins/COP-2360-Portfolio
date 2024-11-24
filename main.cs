// Module 3: excercise 3.1 

using System;

class Program {
  public static void Main (string[] args) {
    //Vars 
    string unitT1 = ("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."); 
    
    string unitT2 = ("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Id semper risus in hendrerit. Viverra mauris in aliquam sem. Arcu felis bibendum ut tristique et egestas quis. Pretium fusce id velit ut tortor pretium viverra suspendisse. Arcu cursus vitae congue mauris rhoncus aenean vel elit. In nisl nisi scelerisque eu ultrices. Mattis enim ut tellus elementum sagittis vitae et leo duis. In massa tempor nec feugiat. Feugiat nibh sed pulvinar proin. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Scelerisque eu ultrices vitae auctor eu augue ut. Ac turpis egestas integer eget aliquet nibh praesent tristique. Viverra suspendisse potenti nullam ac tortor. Tortor id aliquet lectus proin. Dictum non consectetur a erat nam at lectus urna duis. Dui vivamus arcu felis bibendum ut tristique et egestas."); 

    string unitT3 = ("Massa vitae tortor condimentum lacinia quis vel eros donec ac.");
    
    string unitT4 = ("Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.");

    //User inputs 
    Console.WriteLine("Enter your message: ");
    string userInput = Console.ReadLine();

    //Conditonals 
    switch(userInput)
    {
    case "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.":
      Console.WriteLine("Posted");
      break; 

    case "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Id semper risus in hendrerit. Viverra mauris in aliquam sem. Arcu felis bibendum ut tristique et egestas quis. Pretium fusce id velit ut tortor pretium viverra suspendisse. Arcu cursus vitae congue mauris rhoncus aenean vel elit. In nisl nisi scelerisque eu ultrices. Mattis enim ut tellus elementum sagittis vitae et leo duis. In massa tempor nec feugiat. Feugiat nibh sed pulvinar proin. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Scelerisque eu ultrices vitae auctor eu augue ut. Ac turpis egestas integer eget aliquet nibh praesent tristique. Viverra suspendisse potenti nullam ac tortor. Tortor id aliquet lectus proin. Dictum non consectetur a erat nam at lectus urna duis. Dui vivamus arcu felis bibendum ut tristique et egestas.":
      Console.WriteLine("Rejected"); 
      break; 

    case "Massa vitae tortor condimentum lacinia quis vel eros donec ac.":
      Console.WriteLine("Posted");
      break; 

    case "Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.":  
      Console.WriteLine("Posted");
      break; 

    default: 
      Console.WriteLine("Input not detected"); 
      break; 
    }
    
  }
}


//Module 3: Excercise 3.2 

// using System; 

// class Program{
//   public static void Main (string[] args){
//     //vars 
//     Console.WriteLine("Enter the wind speed: ");
//     Double hurricaneInput = Convert.ToDouble(Console.ReadLine()); 

//     //Space
//     Console.WriteLine(" ");

//     if(hurricaneInput >= 157)
//       Console.WriteLine("Catergory Five Hurricane");

//     if((hurricaneInput >= 130) && (hurricaneInput <= 156))
//       Console.WriteLine("Catergory Four Hurricane");

//     if((hurricaneInput >= 111) && (hurricaneInput <= 129))
//       Console.WriteLine("Catergory Three Hurricane");

//     if((hurricaneInput >= 96) && (hurricaneInput <= 110))
//       Console.WriteLine("Catergory Two Hurricane");

//     if((hurricaneInput >= 74) && (hurricaneInput <= 95))
//       Console.WriteLine("Catergory One Hurricane");

//     if(hurricaneInput < 74)
//       Console.WriteLine("Not a hurricane");
//   }

// }
