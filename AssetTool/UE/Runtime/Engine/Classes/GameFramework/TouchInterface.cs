namespace AssetTool
{
    [JsonAsset("TouchInterface")]
    public class UTouchInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}