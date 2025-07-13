namespace AssetTool
{
    [JsonAsset("UVEditorInitializationContext")]
    public class UUVEditorInitializationContext : UUVToolContextObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}