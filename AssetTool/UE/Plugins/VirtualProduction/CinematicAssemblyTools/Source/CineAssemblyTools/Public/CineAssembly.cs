namespace AssetTool
{
    [JsonAsset("CineAssembly")]
    public class UCineAssembly : ULevelSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}