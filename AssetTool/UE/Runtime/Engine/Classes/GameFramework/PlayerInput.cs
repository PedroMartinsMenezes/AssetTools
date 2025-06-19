namespace AssetTool
{
    [JsonAsset("PlayerInput")]
    public class UPlayerInput : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}