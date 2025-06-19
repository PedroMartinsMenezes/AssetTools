namespace AssetTool
{
    [JsonAsset("AvaEdMode")]
    public class UAvaEdMode : UEdMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}