namespace AssetTool
{
    public enum ENiagaraScriptUsage : byte
    {
        Function,
        Module,
        DynamicInput,
        ParticleSpawnScript,
        ParticleSpawnScriptInterpolated,
        ParticleUpdateScript,
        ParticleEventScript,
        ParticleSimulationStageScript,
        ParticleGPUComputeScript,
        EmitterSpawnScript,
        EmitterUpdateScript,
        SystemSpawnScript,
        SystemUpdateScript,
    }

    public enum ENiagaraScriptCompileStatus : byte
    {
        NCS_Unknown,
        NCS_Dirty,
        NCS_Error,
        NCS_UpToDate,
        NCS_BeingCreated,
        NCS_UpToDateWithWarnings,
        NCS_ComputeUpToDateWithWarnings,
        NCS_MAX,
    }

    public enum ENiagaraSimTarget : byte
    {
        CPUSim,
        GPUComputeSim
    }

    public class FNiagaraScriptDataInterfaceCompileInfo
    {
        public FNiagaraTypeDefinition Type = new();

        [Location("bool FNiagaraScriptDataInterfaceCompileInfo::CanExecuteOnTarget(ENiagaraSimTarget SimTarget) const")]
        public bool CanExecuteOnTarget(ENiagaraSimTarget gPUComputeSim)
        {
            return false;
        }
    }
}
