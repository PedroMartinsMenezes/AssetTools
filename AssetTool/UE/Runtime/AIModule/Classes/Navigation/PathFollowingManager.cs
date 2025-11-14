namespace AssetTool
{
    [JsonAsset("PathFollowingManager")]
    public class UPathFollowingManager : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}