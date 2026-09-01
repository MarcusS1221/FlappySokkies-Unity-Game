using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelChanger : MonoBehaviour
{
    public GameObject defaultPrefab;
    public GameObject flowerPrefab;
    public GameObject moltenPrefab;

    //materials
    public Material defaultmatBG;
    public Material defaultmatFL;
    public Material PinkValleymatBG;
    public Material PinkValleymatFL;
    public Material MoltenmatBG;
    public Material MoltenmatFL;

    //btnsimages
    public Sprite defaulticon;
    public Sprite defaulticoncheck;
    public Sprite flowervalleyicon;
    public Sprite flowervalleyiconcheck;
    public Sprite moltenmountainicon;
    public Sprite moltenmountainiconcheck;

    //mesh
    public MeshRenderer BGmesh;
    public MeshRenderer FloorMesh;
    public PipeSpawner pipesSpawner;

    public Button defaultbtnimg;
    public Button moltenmountainbtnimg;
    public Button pinkValleybtnimg;

    public void Default()
    {
        BGmesh.material = defaultmatBG;
        FloorMesh.material = defaultmatFL;

        defaultbtnimg.image.sprite = defaulticoncheck;

        moltenmountainbtnimg.image.sprite = moltenmountainicon;
        pinkValleybtnimg.image.sprite = flowervalleyicon;

        pipesSpawner.prefab = defaultPrefab;
        //pipes
    }

    public void PinkValley()
    {

        BGmesh.material = PinkValleymatBG;
        FloorMesh.material = PinkValleymatFL;

        pinkValleybtnimg.image.sprite = flowervalleyiconcheck;

        defaultbtnimg.image.sprite = defaulticon;
        moltenmountainbtnimg.image.sprite = moltenmountainicon;
        
        pipesSpawner.prefab = flowerPrefab;
    }

    public void MoltenMountains()
    {

        BGmesh.material = MoltenmatBG;
        FloorMesh.material = MoltenmatFL;

        moltenmountainbtnimg.image.sprite = moltenmountainiconcheck;

        defaultbtnimg.image.sprite = defaulticon;
        pinkValleybtnimg.image.sprite = flowervalleyicon;

        pipesSpawner.prefab = moltenPrefab;
    }
}
