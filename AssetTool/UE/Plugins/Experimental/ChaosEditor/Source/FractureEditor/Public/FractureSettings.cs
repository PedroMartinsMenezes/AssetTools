namespace AssetTool
{
    [JsonAsset("FractureSettings")]
    public class UFractureSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}