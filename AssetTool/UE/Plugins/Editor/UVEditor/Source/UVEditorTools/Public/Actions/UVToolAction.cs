namespace AssetTool
{
    [JsonAsset("UVToolAction")]
    public class UUVToolAction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}