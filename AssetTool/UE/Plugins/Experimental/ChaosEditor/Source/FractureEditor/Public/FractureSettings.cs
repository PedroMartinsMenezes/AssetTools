namespace AssetTool
{
    [JsonAsset("FractureSettings")]
    public class UFractureSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}