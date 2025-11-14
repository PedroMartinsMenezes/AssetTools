namespace AssetTool
{
    [JsonAsset("CineAssembly")]
    public class UCineAssembly : ULevelSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}