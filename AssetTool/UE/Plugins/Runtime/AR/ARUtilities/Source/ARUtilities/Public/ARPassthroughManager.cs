namespace AssetTool
{
    [JsonAsset("ARPassthroughManager")]
    public class AARPassthroughManager : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}