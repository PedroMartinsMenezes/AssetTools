namespace AssetTool
{
    [JsonAsset("ARPassthroughManager")]
    public class AARPassthroughManager : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}