namespace AssetTool
{
    [JsonAsset("HairCardGenControllerBase")]
    public class UHairCardGenControllerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}