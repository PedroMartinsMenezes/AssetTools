namespace AssetTool
{
    public class EventGraph : UBlueprint
    {
        public new const string TypeName = "EventGraph";

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}
