using ManBoyInterfaceApp.Domain;

namespace ManBoyInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();

            //AtTheMovie(man);
            AtTheMovie(boy);
            AtTheParty(man);
            AtTheParty(boy);
        }
        static void AtTheParty(IMannerable obj)
        {
            Console.WriteLine("At the Party");
            obj.Wish();
            obj.Depart();
            if (obj is Boy)
            {
                Boy temp = obj as Boy;
                temp.Play();
              
            }
            if (obj is Man)
            {
                Man temp = obj as Man;
                temp.Read();

            }
        }

        static void AtTheMovie(IEmotionable obj)
        {
            Console.WriteLine("At the Movie");
            obj.Cry();
            obj.Laugh();

            
        }

    }
}
