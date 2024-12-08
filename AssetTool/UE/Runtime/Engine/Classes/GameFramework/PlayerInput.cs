namespace AssetTool
{
    [JsonAsset("PlayerInput")]
    public class UPlayerInput : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}