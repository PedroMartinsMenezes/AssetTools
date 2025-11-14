namespace AssetTool
{
    [JsonAsset("Chatroom")]
    public class UChatroom : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}