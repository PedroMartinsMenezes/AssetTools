namespace AssetTool
{
    [JsonAsset("UVToolAction")]
    public class UUVToolAction : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}