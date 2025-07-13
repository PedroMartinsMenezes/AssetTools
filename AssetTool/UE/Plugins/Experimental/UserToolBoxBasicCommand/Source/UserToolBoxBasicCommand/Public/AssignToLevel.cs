namespace AssetTool
{
    [JsonAsset("AssignToLevel")]
    public class UAssignToLevel : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}