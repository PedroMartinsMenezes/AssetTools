namespace AssetTool
{
    [TransferableStruct("MaterialOverrideNanite")]
    public class FMaterialOverrideNanite : ITransferable
    {
        public UInt32 OverrideMaterialRef;
        public FBool bEnableOverride;
        public UInt32 OverrideMaterial;
        public FBool bSerializeAsCookedData;
        public UInt32 OverrideMaterialEditor;

        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.NaniteMaterialOverrideUsesEditorOnly)
            {
                transfer.Move(ref OverrideMaterialRef);
                transfer.Move(ref bEnableOverride);
                transfer.Move(ref OverrideMaterial);
                return this;
            }
            transfer.Move(ref bSerializeAsCookedData);
            if (bSerializeAsCookedData)
            {
                transfer.Move(ref OverrideMaterialEditor);
                transfer.Move(ref OverrideMaterial);
            }
            return default;
        }
    }
}