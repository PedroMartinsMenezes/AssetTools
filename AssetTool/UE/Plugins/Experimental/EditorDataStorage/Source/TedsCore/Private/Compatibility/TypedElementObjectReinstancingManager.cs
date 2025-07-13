namespace AssetTool
{
    [JsonAsset("TedsObjectReinstancingManager")]
    public class UTedsObjectReinstancingManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}