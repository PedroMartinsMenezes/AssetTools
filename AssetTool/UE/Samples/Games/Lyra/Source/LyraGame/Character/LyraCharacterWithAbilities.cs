namespace AssetTool
{
    [JsonAsset("LyraCharacterWithAbilities")]
    public class ALyraCharacterWithAbilities : ALyraCharacter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}