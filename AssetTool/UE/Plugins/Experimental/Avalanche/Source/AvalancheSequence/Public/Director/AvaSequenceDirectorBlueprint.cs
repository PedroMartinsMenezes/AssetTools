namespace AssetTool
{
    [JsonAsset("AvaSequenceDirectorBlueprint")]
    public class UAvaSequenceDirectorBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}