namespace assigment29
{
    public class CustomObject
    {
        private int id;
        private string name;
        public int ID{
            set{id = value;}
            get{return id; }
        }
        public string Name{
            set{name = value;}
            get{return name;}
        }
        public CustomObject(int id, string name){
            ID = id;
            Name = name;
        }
        public override string ToString(){
            return $"Object [ID: {ID}, Name: {Name}].";
        }
        public static  bool operator == (CustomObject obj1, CustomObject obj2){
            if (obj1 is null || obj2 is null) return false;
            return obj1 == obj2;
            //return true if compentent opj1 = component opj2 else false
        }
        public static  bool operator != (CustomObject obj1 , CustomObject obj2){
           return! (obj1 == obj2);
            //return true if compentent opj1 != component opj2 else true

        }

    }
}