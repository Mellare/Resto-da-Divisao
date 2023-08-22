int.TryParse(Console.ReadLine(), out int x);
int.TryParse(Console.ReadLine(), out int y);

       if(x < y){
        if(x == 2){
        for(int i = x + 1; i < y; i++){
         if(i % 5 == 2 || i % 5 == 3){
         Console.WriteLine(i);
        }
      }
    }else{
        for(int i = x; i < y; i++){
         if(i % 5 == 2 || i % 5 == 3){
         Console.WriteLine(i);
    }
}
    }
       }

    if(x > y){
        if(y == 2){
     for(int i = y + 1; i < x; i++){
      if(i % 5 == 2 || i % 5 == 3){
          Console.WriteLine(i);
    }
}
  }else{
         for(int i = y; i < x; i++){
      if(i % 5 == 2 || i % 5 == 3){
          Console.WriteLine(i);
    }
}
 }
  }
   }
    }
