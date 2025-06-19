namespace AssetTool
{
    [JsonAsset("PathFollowingManager")]
    public class UPathFollowingManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}