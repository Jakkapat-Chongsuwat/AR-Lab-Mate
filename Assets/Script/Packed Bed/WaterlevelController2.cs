using UnityEngine;
using UnityEngine.UI;

public class WaterlevelController2 : MonoBehaviour
{
    //water part
    public Renderer water;

    //Effect part
    public GameObject packedColumnEffectContainer;

    private BubbleDuplicater bubbleDuplicater;
    public GameObject particleJigglyBubbleSoapy;
    private ParticleSystem.EmissionModule bubbleParticle;

    private ParticleSystem bubbleParticlePara;
    private ParticleSystem.MainModule main;

    private GameObject[] destroyBubble;

    //Drop down part
    public Dropdown airFlowrateDropdown;

    public Dropdown waterFlowrateDropdown;
    public Button calculateButton;

    private float waterLevel;
    private float airValue;
    private float waterValue;


    // Start is called before the first frame update
    private void Start()
    {
        //set default water level
        waterLevel = 1;
        water = water.GetComponent<Renderer>();
        SetNewAlpha();

        //???
        airFlowrateDropdown.onValueChanged.AddListener(delegate
        {
            OnAirValueChanged();
        });

        waterFlowrateDropdown.onValueChanged.AddListener(delegate
        {
            OnWaterValueChanged();
        });

        //Access Particle System parameter
        bubbleParticlePara = particleJigglyBubbleSoapy.GetComponent<ParticleSystem>();
        main = bubbleParticlePara.main;

        //Disable Bubble Particle System
        bubbleParticle = particleJigglyBubbleSoapy.GetComponent<ParticleSystem>().emission;
        bubbleParticle.enabled = false;
        //Get script component
        bubbleDuplicater = packedColumnEffectContainer.GetComponent<BubbleDuplicater>();

        //Disable bubble script
        bubbleDuplicater.enabled = false;
    }

    private void Update()
    {
        //Collect old bubble with tag
        destroyBubble = GameObject.FindGameObjectsWithTag("Generated Bubble");
    }

    private void OnAirValueChanged()
    {
        //Set dropdown value to float
        string airIndex = airFlowrateDropdown.options[airFlowrateDropdown.value].text;
        float.TryParse(airIndex, out airValue);
        Debug.Log("You have selected " + airValue);
    }

    private void OnWaterValueChanged()
    {
        //Set dropdown value to float
        string waterIndex = waterFlowrateDropdown.options[waterFlowrateDropdown.value].text;
        float.TryParse(waterIndex, out waterValue);
        Debug.Log("You have selected " + waterValue);
    }

    public void OnCalculate()
    {
        //Destroy old bubble;
        DestroyBubble();

        //Set new bubble to inactive
        bubbleParticle.enabled = false;
        bubbleDuplicater.enabled = false;


        //Calculate the flow rate and scale with water level
        if ((airValue == 2.5) & (waterValue >= 20 && waterValue <= 70))
        {
            waterLevel = (float)(0.9 - ((waterValue - 20) / (70 - 20) * 0.9));
            Debug.Log("WaterLevel =" + waterLevel);

            if (waterValue >= 70)
            {
                bubbleParticle.enabled = true;
                bubbleDuplicater.enabled = true;
                bubbleDuplicater.CreateElements();
                Debug.Log("Bubble Generated");
            }
        }

        else if ((airValue == 3) & (waterValue >= 20 && waterValue <= 70))
        {
            waterLevel = (float)(0.9 - ((waterValue - 20) / (70 - 20) * 0.9));
            Debug.Log("WaterLevel =" + waterLevel);

            if (waterValue >= 50)
            {
                bubbleParticle.enabled = true;
                main.startLifetime = 0.2f / ((85 - waterValue)/10);
                bubbleDuplicater.enabled = true;
                bubbleDuplicater.CreateElements();
                Debug.Log("Bubble Generated");
            }
        }

        else if ((airValue == 3.5) & (waterValue >= 20 && waterValue <= 70))
        {
            waterLevel = (float)(0.9 - ((waterValue - 20) / (70 - 20) * 0.9));
            Debug.Log("WaterLevel =" + waterLevel);

            if (waterValue >= 40)
            {
                bubbleParticle.enabled = true;
                main.startLifetime = 0.2f / ((85 - waterValue) / 10);
                bubbleDuplicater.enabled = true;
                bubbleDuplicater.CreateElements();
                Debug.Log("Bubble Generated");
            }
        }

        SetNewAlpha();
    }

    private void SetNewAlpha()
    {
        // waterLevel = float.Parse(waterLevelValue.text);
        water.material.SetFloat("_Cutoff", waterLevel);
        Debug.Log("_Cutoff was set to" + waterLevel);
    }

    private void DestroyBubble()
    {
        //Destroy old bubble
        for (int i = 0; i < destroyBubble.Length; i++)
        {
            Destroy(destroyBubble[i]);
        }
    }
}