namespace AssetTool
{
    [JsonAsset("ChangeViewMode")]
    public class UChangeViewMode : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}