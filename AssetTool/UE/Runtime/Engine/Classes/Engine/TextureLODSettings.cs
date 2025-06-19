namespace AssetTool
{
    [JsonAsset("TextureLODSettings")]
    public class UTextureLODSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}