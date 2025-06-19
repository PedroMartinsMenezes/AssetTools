namespace AssetTool
{
    [JsonAsset("CrowdManager")]
    public class UCrowdManager : UCrowdManagerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}