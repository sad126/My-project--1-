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
            else if(obj1.ID.Equals(obj2.ID)&& obj1.Name.Equals(obj2.Name)){
                return true;
            }
            return false;
            //return true if compentent opj1 = component opj2 else false
        }
        public static  bool operator != (CustomObject obj1 , CustomObject obj2){

          if (obj1 is null || obj2 is null) return false;
            else if(obj1.ID.Equals(obj2.ID)&& obj1.Name.Equals(obj2.Name)){
                return false;
            }
            return true;
            //return true if compentent opj1 != component opj2 else false
        }

    }
}