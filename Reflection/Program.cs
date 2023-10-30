// See https://aka.ms/new-console-template for more information


using Assignment1;

House house = new House()
{
    Rooms = new List<Room>
    {
        new Room
        {
            RoomNumber="302",
            Windows=new List<Window>
            { new Window {Height=5,Width=10
              ,Locks=new List<Lock>

              { 
                  new Lock{LockNumber=2}
              }},

              new Window {Height=30,Width=20,
              Locks=new List<Lock>
              {
                  new Lock{LockNumber=2}
              } }



            }


        },

        new Room 
        {
            RoomNumber="502",
            Windows=new List<Window>
            { new Window {Height=25, Width=55} ,
                new Window {Height=35, Width=40}
            }


        }


    },

};

Building building = new Building();

SimpleMapper mapper = new SimpleMapper();
mapper.Copy(house, building);

foreach(var room in building.Rooms)
{
    Console.WriteLine("Room Number: " + room.RoomNumber);

    foreach (var window in room.Windows)
    {
        Console.WriteLine(window.Height);
        Console.WriteLine(window.Width);

        foreach (var l in window.Locks)
        {
            Console.WriteLine(l.LockNumber) ;
        }

    }

    Console.WriteLine(); // Adding a blank line between rooms for clarity
}


