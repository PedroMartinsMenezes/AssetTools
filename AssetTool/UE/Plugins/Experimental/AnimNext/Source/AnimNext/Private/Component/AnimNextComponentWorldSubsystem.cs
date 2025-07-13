namespace AssetTool
{
    [JsonAsset("AnimNextComponentWorldSubsystem")]
    public class UAnimNextComponentWorldSubsystem : UAnimNextWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}