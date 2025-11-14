namespace AssetTool
{
    [JsonAsset("TextureLODSettings")]
    public class UTextureLODSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}