using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemManager : MonoBehaviour
{
    private PlayerManager _playerManager;
    private Dictionary<GameObject, GameObject> _negativeBuffDict = new Dictionary<GameObject, GameObject>();

    [SerializeField] private List<GameObject> _debuffEffects = new List<GameObject>();
    [SerializeField] private List<GameObject> _otherEffects = new List<GameObject>();
    [SerializeField] private List<GameObject> _auraEffects = new List<GameObject>();
    [SerializeField] private float _auraDuration = 1f;
    [SerializeField] private float _auraTick = 0.5f;
    [SerializeField] private float _auraDamage = 0.1f;
    [SerializeField] private Vector3 _auraSize = new Vector3(2f, 2f, 2f);

    public List<GameObject> GetDebuffEffects { get => _debuffEffects; } 
    private bool _isAuraExist = false;
    private GameObject _auraType;

    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
    }

    private void Initialize()
    {
        _playerManager = FindObjectOfType<PlayerManager>();
        for (int i = 0; i < _playerManager.mPlayersList.Count; i++)
        {
            _playerManager.mPlayersList[i].GetComponent<HeroStats>().onDebuffActivated += DebuffEffectOn;
            _playerManager.mPlayersList[i].GetComponent<HeroStats>().onDebuffDeActivated += DebuffEffectOff;

        }
    }

    private void DebuffEffectOn(GameObject hero)
    {
        switch (hero.GetComponent<HeroStats>().DeBuff)
        {
            case StatusEffects.NegativeEffects.OnFire:
                Burning(hero);
                break;
            case StatusEffects.NegativeEffects.Slowed:
                Slowed(hero);
                break;
            case StatusEffects.NegativeEffects.Stunned:
                break;            
            default:
                break;
        }
    }


    private void DebuffEffectOff(GameObject hero)
    {
        foreach (var statuseffect in _negativeBuffDict)
        {
            if (statuseffect.Key.GetComponent<HeroStats>().DeBuff == StatusEffects.NegativeEffects.None)
            {
                statuseffect.Value.GetComponent<ParticleSystem>().Stop();
                _negativeBuffDict.Remove(statuseffect.Key);
                break;
            }
        }
    }

    private void Burning(GameObject hero)
    {
        ParticleSystem ps = _debuffEffects[0].GetComponent<ParticleSystem>();
        
        GameObject BurningEffect = Instantiate(ps.gameObject, new Vector3(hero.transform.position.x,hero.transform.position.y - 1) , Quaternion.identity);
        BurningEffect.transform.parent = hero.transform;
        BurningEffect.transform.localScale = new Vector3(1f, 1.5f, 1f);
        BurningEffect.GetComponent<ParticleSystem>().Play();
        if (_negativeBuffDict.ContainsKey(hero))
        {
            _negativeBuffDict.Remove(hero);
            _negativeBuffDict.Add(hero, BurningEffect);
        }
        else
        {
            _negativeBuffDict.Add(hero, BurningEffect);
        }
    }

    private void Slowed(GameObject hero)
    {
        ParticleSystem ps = _debuffEffects[1].GetComponent<ParticleSystem>();

        GameObject SlowEffect = Instantiate(ps.gameObject, hero.transform.position, Quaternion.identity);
        SlowEffect.transform.parent = hero.transform;
        SlowEffect.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
        SlowEffect.GetComponent<ParticleSystem>().Play();
    }

    public void FireAura(GameObject hero)
    {
        Debug.Log("reached");
        if (!_isAuraExist)
        {
            _auraType = Instantiate(_auraEffects[0].gameObject, hero.transform.position, Quaternion.identity);
            _auraType.tag = hero.tag;
            _auraType.GetComponent<FireAura>().SetDamage = _auraDamage;
            _auraType.GetComponent<FireAura>().SetTick = _auraTick;
            _auraType.transform.parent = hero.transform;
            _auraType.transform.localScale = _auraSize;
            _auraType.GetComponent<ParticleSystem>().Play();
            _isAuraExist = true;
        }
        else
        {
            _auraType.GetComponent<ParticleSystem>().Play();
        }
        StartCoroutine(TurnOffAura(_auraType));
    }
    
    private IEnumerator TurnOffAura(GameObject Aura)
    {
        yield return new WaitForSeconds(_auraDuration);
        _isAuraExist = false;
        Destroy(Aura);
    }
}
