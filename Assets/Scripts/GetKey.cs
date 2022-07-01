using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    ParticleSystemForceField forceField;
    ParticleSystem ps;
    float rotationSpeed = 0;

    bool flagq = false;
    bool flagw = false;
    bool flage = false;
    bool flagr = false;

    // Start is called before the first frame update
    void Start()
    {
        forceField = GameObject.Find("Force").GetComponent<ParticleSystemForceField>();
        ps = GameObject.Find("Particle").GetComponent<ParticleSystem>();
        //var property = ps.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Q) && forceField.gravityFocus > 0 && forceField.gravityFocus <= 1 
            && flagw == false && flage == false && flagr == false)
        {
            forceField.gravityFocus -= 0.004f;
            rotationSpeed += 0.1f;
            forceField.rotationSpeed = rotationSpeed;

            flagq = true;
            

            if (Input.GetKey(KeyCode.Q) && forceField.gravityFocus < 0)
            {
                //var main = ps.main;
                //main.startColor = new Color(326, 119, 41, 1);
                var color = ps.colorOverLifetime;
                color.enabled = true;
                forceField.gravityFocus = 0;

                
            }
            
        }

        if (Input.GetKey(KeyCode.A) && forceField.gravityFocus >= 0 && forceField.gravityFocus < 1 && flagq == true)
        {
            var color = ps.colorOverLifetime;
            color.enabled = false;
            forceField.gravityFocus += 0.006f;
            rotationSpeed -= 0.15f;
            forceField.rotationSpeed = rotationSpeed;

            if (Input.GetKey(KeyCode.A) && forceField.gravityFocus > 1)
            {
                //var main = ps.main;
                //main.startColor = new Color(326, 119, 41, 1);
                
                forceField.gravityFocus = 1;
                rotationSpeed = 0;
                forceField.rotationSpeed = rotationSpeed;

                flagq = false;
                flagw = false;
                flage = false;
                flagr = false;
            }

        }

        if (Input.GetKey(KeyCode.R) && forceField.gravityFocus > 0 && forceField.gravityFocus <= 1
            && flagq == false && flagw == false && flage == false)
        {
            forceField.gravityFocus -= 0.004f;
            rotationSpeed -= 0.1f;
            forceField.rotationSpeed = rotationSpeed;

            flagr = true;

            if (Input.GetKey(KeyCode.R) && forceField.gravityFocus < 0)
            {
                //var main = ps.main;
                //main.startColor = new Color(326, 119, 41, 1);
                var color = ps.colorOverLifetime;
                color.enabled = true;
                forceField.gravityFocus = 0;

                
            }

        }

        if (Input.GetKey(KeyCode.F) && forceField.gravityFocus >= 0 && forceField.gravityFocus < 1 && flagr == true)
        {
            var color = ps.colorOverLifetime;
            color.enabled = false;
            forceField.gravityFocus += 0.006f;
            rotationSpeed += 0.15f;
            forceField.rotationSpeed = rotationSpeed;

            if (Input.GetKey(KeyCode.F) && forceField.gravityFocus > 1)
            {
                //var main = ps.main;
                //main.startColor = new Color(326, 119, 41, 1);

                forceField.gravityFocus = 1;
                rotationSpeed = 0;
                forceField.rotationSpeed = rotationSpeed;

                flagq = false;
                flagw = false;
                flage = false;
                flagr = false;
            }

        }

        /*****************************************************************/
        /*****************************************************************/

        if (Input.GetKey(KeyCode.W) && forceField.gravityFocus > 0 && forceField.gravityFocus <= 1
            && flagq == false && flage == false && flagr == false)
        {

            flagw = true;

            forceField.gravityFocus -= 0.0026f;
            var xl = ps.forceOverLifetime;
            xl.enabled = true;
            AnimationCurve curve = new AnimationCurve();
            curve.AddKey(0.0f, -7);
            curve.AddKey(1, -7);
            xl.x = new ParticleSystem.MinMaxCurve(1, curve);

            if (Input.GetKey(KeyCode.W) && forceField.gravityFocus < 0.3f)
            {
                //var main = ps.main;
                //main.startColor = new Color(326, 119, 41, 1);
                var color = ps.colorOverLifetime;
                color.enabled = true;
                forceField.gravityFocus = 0.3f;

                

            }

        }

        if (Input.GetKey(KeyCode.S) && forceField.gravityFocus >= 0 && forceField.gravityFocus < 1 && flagw == true)
        {
            var color = ps.colorOverLifetime;
            color.enabled = false;
            forceField.gravityFocus += 0.006f;

            

            if (Input.GetKey(KeyCode.S) && forceField.gravityFocus > 1)
            {
                //var main = ps.main;
                //main.startColor = new Color(326, 119, 41, 1);

                forceField.gravityFocus = 1;

                var xl = ps.forceOverLifetime;
                AnimationCurve curve = new AnimationCurve();
                curve.AddKey(0.0f, 0.0f);
                curve.AddKey(1, 0.0f);
                xl.x = new ParticleSystem.MinMaxCurve(1, curve);
                xl.enabled = false;

                flagq = false;
                flagw = false;
                flage = false;
                flagr = false;

            }

        }

        if (Input.GetKey(KeyCode.E) && forceField.gravityFocus > 0 && forceField.gravityFocus <= 1
            && flagq == false && flagw == false && flagr == false)
        {
            flage = true;

            forceField.gravityFocus -= 0.0026f;
            var xl = ps.forceOverLifetime;
            xl.enabled = true;
            AnimationCurve curve = new AnimationCurve();
            curve.AddKey(0.0f, 7);
            curve.AddKey(1, 7);
            xl.x = new ParticleSystem.MinMaxCurve(1, curve);

            if (Input.GetKey(KeyCode.E) && forceField.gravityFocus < 0.3f)
            {
                //var main = ps.main;
                //main.startColor = new Color(326, 119, 41, 1);
                var color = ps.colorOverLifetime;
                color.enabled = true;
                forceField.gravityFocus = 0.3f;

                
            }

        }

        if (Input.GetKey(KeyCode.D) && forceField.gravityFocus >= 0 && forceField.gravityFocus < 1 && flage == true)
        {
            var color = ps.colorOverLifetime;
            color.enabled = false;
            forceField.gravityFocus += 0.006f;

            var xl = ps.forceOverLifetime;
            AnimationCurve curve = new AnimationCurve();
            curve.AddKey(0.0f, 0.0f);
            curve.AddKey(1, 0.0f);
            xl.x = new ParticleSystem.MinMaxCurve(1, curve);
            xl.enabled = false;

            if (Input.GetKey(KeyCode.D) && forceField.gravityFocus > 1)
            {
                //var main = ps.main;
                //main.startColor = new Color(326, 119, 41, 1);

                forceField.gravityFocus = 1;

                flagq = false;
                flagw = false;
                flage = false;
                flagr = false;

            }

        }

    }
}
