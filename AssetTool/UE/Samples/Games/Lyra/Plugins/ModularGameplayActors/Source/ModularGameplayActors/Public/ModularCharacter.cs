namespace AssetTool
{
    [JsonAsset("ModularCharacter")]
    public class AModularCharacter : ACharacter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}