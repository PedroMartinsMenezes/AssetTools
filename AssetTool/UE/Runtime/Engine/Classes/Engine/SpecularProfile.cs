namespace AssetTool
{
    [JsonAsset("SpecularProfile")]
    public class USpecularProfile : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}