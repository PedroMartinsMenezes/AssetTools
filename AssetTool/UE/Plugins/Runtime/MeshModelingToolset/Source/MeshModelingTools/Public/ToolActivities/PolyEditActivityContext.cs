namespace AssetTool
{
    [JsonAsset("PolyEditActivityContext")]
    public class UPolyEditActivityContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}