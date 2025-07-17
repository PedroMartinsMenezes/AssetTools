namespace AssetTool
{
    [JsonAsset("LyraCharacter")]
    public class ALyraCharacter : AModularCharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}