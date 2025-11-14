namespace AssetTool
{
    [JsonAsset("AnimNextComponentWorldSubsystem")]
    public class UAnimNextComponentWorldSubsystem : UAnimNextWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}