namespace AssetTool
{
    [JsonAsset("LyraCharacter")]
    public class ALyraCharacter : AModularCharacter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}