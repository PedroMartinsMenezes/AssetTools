namespace AssetTool
{
    [JsonAsset("Chatroom")]
    public class UChatroom : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}