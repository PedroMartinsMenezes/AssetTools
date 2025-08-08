namespace AssetTool
{
    [JsonAsset("ChaosVDParticleEditorDataFactory")]
    public class UChaosVDParticleEditorDataFactory : UEditorDataStorageFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}