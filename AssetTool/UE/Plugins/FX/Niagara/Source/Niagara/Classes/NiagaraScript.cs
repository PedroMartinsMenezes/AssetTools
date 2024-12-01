namespace AssetTool
{
    [JsonAsset("NiagaraScript")]
    public class UNiagaraScript : UNiagaraScriptBase
    {
        public ENiagaraScriptUsage Usage = ENiagaraScriptUsage.ParticleGPUComputeScript;
        public List<FNiagaraShaderScript> LoadedResources;
        public FNiagaraVMExecutableData CachedScriptVM = new();
        public bool IsValidShaderScript;

        [Location("void UNiagaraScript::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            ///bool IsValidShaderScript = false;
            ///if (!Supports.DontCompileGPUWhenNotNeeded)
            ///{
            ///    IsValidShaderScript = Usage != ENiagaraScriptUsage.Module && Usage != ENiagaraScriptUsage.Function && Usage != ENiagaraScriptUsage.DynamicInput
            ///        && (!Supports.NiagaraShaderMapCooking2 || (Usage != ENiagaraScriptUsage.SystemSpawnScript && Usage != ENiagaraScriptUsage.SystemUpdateScript))
            ///        && (!Supports.NiagaraCombinedGPUSpawnUpdate || (Usage != ENiagaraScriptUsage.ParticleUpdateScript && Usage != ENiagaraScriptUsage.EmitterSpawnScript && Usage != ENiagaraScriptUsage.EmitterUpdateScript));
            ///}
            ///else if (!Supports.MovedToDerivedDataCache)
            ///{
            ///    IsValidShaderScript = LegacyCanBeRunOnGpu();
            ///}
            ///else
            ///{
            ///    IsValidShaderScript = CanBeRunOnGpu();
            ///}
            ///if (IsValidShaderScript)
            ///{
            ///    if (!Supports.UseHashesToIdentifyCompileStateOfTopLevelScripts)
            ///    {
            ///        foreach (FNiagaraScriptDataInterfaceCompileInfo InterfaceInfo in CachedScriptVM.DataInterfaceInfo)
            ///        {
            ///            //if (InterfaceInfo.Type.GetClass() == UNiagaraDataInterfaceSkeletalMesh::StaticClass() ||
            ///            //    InterfaceInfo.Type.GetClass() == UNiagaraDataInterfaceStaticMesh::StaticClass())
            ///            //{
            ///            //    IsValidShaderScript = false;
            ///            //}
            ///        }
            ///    }
            ///}

            if (transfer.IsReading && GlobalObjects.CurrentObject.NextOffset > transfer.Position)
            {
                IsValidShaderScript = true;
            }

            SerializeNiagaraShaderMaps(transfer, IsValidShaderScript);
            return this;
        }

        ///[Location("bool UNiagaraScript::CanBeRunOnGpu()const")]
        ///private bool CanBeRunOnGpu()
        ///{
        ///    if (Usage != ENiagaraScriptUsage.ParticleGPUComputeScript)
        ///    {
        ///        return false;
        ///    }
        ///    if (!CachedScriptVM.IsValid())
        ///    {
        ///        return false;
        ///    }
        ///    foreach (FNiagaraScriptDataInterfaceCompileInfo InterfaceInfo in CachedScriptVM.DataInterfaceInfo)
        ///    {
        ///        if (InterfaceInfo.Type.IsValid() && !InterfaceInfo.CanExecuteOnTarget(ENiagaraSimTarget.GPUComputeSim))
        ///        {
        ///            return false;
        ///        }
        ///    }
        ///    return true;
        ///}

        ///private bool LegacyCanBeRunOnGpu()
        ///{
        ///    throw new NotImplementedException();
        ///}

        [Location("void UNiagaraScript::SerializeNiagaraShaderMaps(FArchive& Ar, int32 NiagaraVer, bool IsValidShaderScript)")]
        private void SerializeNiagaraShaderMaps(Transfer transfer, bool IsValidShaderScript)
        {
            IsValidShaderScript = (Supports.NiagaraShaderMaps) && (!Supports.NiagaraShaderMapCooking || IsValidShaderScript);
            if (!IsValidShaderScript)
            {
                return;
            }
            bool HasEditorData = !GlobalObjects.IsFilterEditorOnly();
            if (HasEditorData)
            {
                transfer.Move(ref LoadedResources);
            }
        }
    }

    [TransferibleStruct("NiagaraVMExecutableData")]
    public class FNiagaraVMExecutableData : ITransferible
    {
        public UScriptStruct scriptStruct = new();
        public ENiagaraScriptCompileStatus LastCompileStatus = ENiagaraScriptCompileStatus.NCS_UpToDate;
        public List<FNiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo = [];

        [Location("void FNiagaraVMExecutableData::SerializeData(FArchive& Ar, bool bDDCData)")]
        public ITransferible Move(Transfer transfer)
        {
            scriptStruct.SerializeTaggedProperties(transfer);
            return this;
        }

        public bool IsValid()
        {
            return LastCompileStatus != ENiagaraScriptCompileStatus.NCS_Unknown;
        }
    }
}