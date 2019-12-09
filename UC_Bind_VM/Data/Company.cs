using UC_Bind_VM.Infrastructures;

namespace UC_Bind_VM.Data
{
    public class Company : OnPropertyChangedClass
    {
        int full_cost;
        int part_cost;
        public int FullCost { get => full_cost; set => SetProperty(ref full_cost, value); }
        public int PartCost { get => part_cost; set => SetProperty(ref part_cost, value); } 
    }
}
